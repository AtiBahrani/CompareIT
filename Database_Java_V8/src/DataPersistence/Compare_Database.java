package DataPersistence;

import domain.User;
import domain.UserList;
import domain.UserWish;
import utility.persistence.MyDatabase;

import java.sql.SQLException;
import java.util.ArrayList;

public class Compare_Database implements ICompare_Database {


    private MyDatabase db;

    //    Fill out with your postgres password
    private static final String DRIVER = "org.postgresql.Driver";
    private static final String URL = "jdbc:postgresql://localhost:5432/postgres";
    private static final String USER = "postgres";
    private static final String PASSWORD = "";


    public Compare_Database() {
        try {
            this.db = new MyDatabase(DRIVER, URL, USER, PASSWORD);
            System.out.println("connect to database");

        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }



    @Override
    //The method passes a String type username as a parameter and returns a wishList for a specific user.
    public ArrayList<UserWish> loadWishes(String username) throws SQLException {
        String sqlWish = "SELECT DISTINCT UserWish.username,URL,title From Public.Wish INNER JOIN " +
                " Public.UserWish ON UserWish.wishId=Wish.wishId WHERE username=?;";
        ArrayList<UserWish> list = new ArrayList<>();
        ArrayList<Object[]> wishes = db.query(sqlWish, username);
        for (int i = 0; i < wishes.size(); i++) {
            Object[] array = wishes.get(i);
            UserWish wish = new UserWish(array[0] + "", array[1] + "", array[2] + "");
            list.add(wish);
        }
        return list;
    }


    @Override
    //This method removes a wish
    //check if removes from both tables
    public synchronized boolean removeWish(UserWish wish) throws SQLException {
        String wishToRemove = "SELECT UserWish.wishId,Wish.URL, Wish.Title,UserWish.username " +
                "FROM Public.Wish INNER JOIN Public.UserWish ON Wish.wishId=UserWish.wishId " +
                "WHERE URL=? AND title=? AND UserWish.username=?;";
        String sql = "DELETE FROM public.Wish where  wishId=?;";


        ArrayList<Object[]> rows = db.query(wishToRemove, wish.getURL(), wish.getTitle(), wish.getUsername());
        int w = Integer.parseInt(rows.get(0)[0].toString());
        db.update(sql, w);

        return true;


    }


    @Override
    //This method registers a new wish
    public synchronized boolean registerWish(String username, String url, String title) throws SQLException {

        boolean result = true;
        String newWish = "INSERT INTO Public.Wish(title,URL)" +
                "VALUES(?,?);";
        String wishId = "SELECT wishId FROM Public.Wish WHERE title=? AND URL=?  ;";
        String userWish = "INSERT INTO Public.UserWish (username,wishId) VALUES(?,?);";

        ArrayList<UserWish> wl = loadWishes(username);

        for (int i = 0; i < wl.size(); i++) {
            if ((wl.get(i).getURL().equals(url)) && (wl.get(i).getTitle().equals(title))) {
                System.out.println("The item is already in the wish list!");

                result = false;

            }
        }
        if (result) {
            db.update(newWish, title, url);

            ArrayList<Object[]> wId = db.query(wishId, title, url);
            int id = Integer.parseInt(wId.get(wId.size() - 1)[0].toString());
            db.update(userWish, username, id);

            System.out.println("wish added");
        }
        return result;


    }


    //modify to return also the wishlist with the user  and remove password
    public synchronized User loadOneUser(String username) throws SQLException {
        String sql = "SELECT Users.firstname,Users.lastname,Users.username,Users.email,Users.isAdmin " +
                "FROM Public.Users  WHERE username=?; ";

        User user = null;

        ArrayList<Object[]> user1 = db.query(sql, username);
        for (int i = 0; i < user1.size(); i++) {
            Object[] array = user1.get(i);
            user = new User(array[0] + "", array[1] + "", array[2] + "", array[3] + "", (boolean) array[4], loadWishes(username));
        }
        return user;
    }


    //This method adds a user

    public synchronized void registerUser(User user) throws SQLException {

        String person = "INSERT INTO Public.Users(username,password,firstname,lastname,email,isAdmin)" +
                " VALUES (?,?,?,?,?,?);";
        db.update(person, user.getID(), user.getPassword(), user.getFirstName(),
                user.getLastName(), user.getEmail(), user.isAdmin());

        System.out.println("Added to database");
    }

    @Override
    public synchronized boolean userExists(String username) throws SQLException {
        String sql = "SELECT username FROM Public.Users  WHERE username=?;";

        ArrayList<Object[]> Id = null;

        Id = db.query(sql, username);
        int[] ids = new int[Id.size()];

        for (int i = 0; i < ids.length; i++) {
            String id = String.valueOf(Id.get(i)[0]);

            if (id.equals(username))
                System.out.println("ID is taken!");
            return true;
        }


        return false;


    }


    //This method deletes a specific user
    public synchronized void removeUser(User user) throws SQLException {
        String sql = "DELETE FROM Public.Users WHERE username=?;";
        db.update(sql, user.getID());
    }


    @Override
    public synchronized boolean validateLogin(String username, String password) throws SQLException {
        boolean result = false;
        String sql = "SELECT username, password FROM Public.Users WHERE username=? ;";
        ArrayList<Object[]> user = db.query(sql, username);
        for (int i = 0; i < user.size(); i++) {
            Object[] array = user.get(i);
            String us = array[0] + "";
            String ps = array[1] + "";
            if (us.equals(username) && ps.equals(password)) {
                System.out.println("login is validated!");
                result = true;
            } else {
                System.out.println("wrong ID or password!");
            }
        }
        return result;
    }

}





