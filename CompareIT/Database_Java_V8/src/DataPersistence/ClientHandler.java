package DataPersistence;

import com.google.gson.*;
import com.google.gson.internal.bind.SqlDateTypeAdapter;
import domain.*;


import java.io.*;
import java.net.Socket;
import java.sql.SQLException;
import java.util.ArrayList;


public class ClientHandler implements Runnable {

    private ICompare_Database database = new Compare_Database();
    private InputStream in;
    private OutputStream out;
    private Gson gson = new Gson();

    public ClientHandler(Socket socket) throws IOException {
        in = socket.getInputStream();
        out = socket.getOutputStream();


    }

    @Override
    public void run() {
        try {

            receive();

        } catch (Exception e) {
            e.printStackTrace();
        }


    }

    public void receive() throws IOException, SQLException {
        byte[] lenBytes = new byte[4];
        in.read(lenBytes, 0, 4);
        int len = (((lenBytes[3] & 0xff) << 24) | ((lenBytes[2] & 0xff) << 16) |
                ((lenBytes[1] & 0xff) << 8) | (lenBytes[0] & 0xff));
        byte[] receivedBytes = new byte[len];
        in.read(receivedBytes, 0, len);
        String received = new String(receivedBytes, 0, len);

        //Registering in the database
        if (received.endsWith("1")) {
            String s = received.substring(0, received.length() - 1);
            User user = gson.fromJson(s, User.class);
            register(user);
        } else if (received.endsWith("2")) {
            String s = received.substring(0, received.length() - 1);
            Login login = gson.fromJson(s, Login.class);
            boolean reply = validateLogin(login.getID(), login.getPassword());
            send(reply);
            if (reply == true) {
                System.out.println(login);
                System.out.println("" + loadWishes(login.getID()));
                send(loadWishes(login.getID()));
            }
        } else if (received.endsWith("3")) {
            String uw = received.substring(0, received.length() - 1);
            UserWish userWish = gson.fromJson(uw, UserWish.class);
            System.out.println("wish received " + userWish);
            send(registerWish(userWish.getUsername(), userWish.getURL(), userWish.getTitle()));

        } else if (received.endsWith("4")) {
            String uw = received.substring(0, received.length() - 1);
            UserWish userWish = gson.fromJson(uw, UserWish.class);
            System.out.println(userWish);
            //to send the user again with the updated wish list
            //send(removeWish(userWish));
            //if u only want the username with a wish send this one
            send(loadWishes(userWish.getUsername()));
        }// else if to get a username with number 5 sending the user back
        else {
            System.out.println("Invalid request!");
        }
    }


    public void send(Object message) throws IOException {
        String toSend = gson.toJson(message);
        byte[] toSendBytes = toSend.getBytes();
        int toSendLen = toSendBytes.length;
        byte[] toSendLenBytes = new byte[4];
        toSendLenBytes[0] = (byte) (toSendLen & 0xff);
        toSendLenBytes[1] = (byte) ((toSendLen >> 8) & 0xff);
        toSendLenBytes[2] = (byte) ((toSendLen >> 16) & 0xff);
        toSendLenBytes[3] = (byte) ((toSendLen >> 24) & 0xff);
        out.write(toSendLenBytes);
        out.write(toSendBytes);
    }


    public void register(User user) throws IOException {

        try {
            if (!(database.userExists(user.getID()))) {
                database.registerUser(user);
                send(true);
            }
        } catch (SQLException e) {
            System.out.println("ID is taken!");
        }


        send(false);


    }

    public boolean validateLogin(String id, String password) throws SQLException {
        return database.validateLogin(id, password);

    }

    public User loadOneUser(String username) throws SQLException {
        return database.loadOneUser(username);
    }

    public boolean registerWish(String username, String url, String title) throws SQLException {
        return database.registerWish(username, url, title);
    }

    public boolean removeWish(UserWish wish) throws SQLException {
        return database.removeWish(wish);
    }

    public ArrayList<UserWish> loadWishes(String username) throws SQLException {
        return database.loadWishes(username);
    }

}

