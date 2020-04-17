package domain;

import java.io.Serializable;
import java.util.ArrayList;

public class UserList implements Serializable {
    private ArrayList<User> userList;

    public UserList(){
        this.userList=new ArrayList<>();
    }

    public ArrayList<User> getUserList() {
        return userList;
    }



    public void addUser(User user){

        userList.add(user);
    }
    public void removeUser(User user){

          // if(userList.get(i).getID().equals(user.getID()))
        userList.remove(user);


    }

    @Override
    public String toString() {
        return "UserList{" +
                "userList=" + userList +
                '}';
    }
}
