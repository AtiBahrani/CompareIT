package DataPersistence;

import domain.User;
import domain.UserWish;

import java.sql.SQLException;
import java.util.ArrayList;


public interface ICompare_Database {
    /* UserList loadUsers() throws SQLException;*/
    ArrayList<UserWish> loadWishes(String username) throws SQLException;

    void registerUser(User user) throws SQLException;

    void removeUser(User user) throws SQLException;

    boolean userExists(String username) throws SQLException;

    boolean validateLogin(String username, String password) throws SQLException;

    boolean removeWish(UserWish userWish) throws SQLException;

    boolean registerWish(String username,String url, String title) throws SQLException;

    User loadOneUser(String username) throws SQLException;

}



