package DataPersistence;

import domain.User;
import domain.UserWish;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.sql.SQLException;

import static org.junit.Assert.assertEquals;


public class Compare_DatabaseTest {
    private Compare_Database db;
    private User user;

    @Before
    public void setUp() throws Exception {
        this.db = new Compare_Database();
    }

    @Test
    public void loadOneUser() throws SQLException {
        user = new User("Loli", "Niko", "kolikol", "khaliband", "no@ddl.com", false);
        //assertEquals(user,db.loadOneUser(user.getID()));
        //System.out.println(db.loadOneUser(username));

    }

    @Test
    public void registerUser() throws SQLException {
        user = new User("Loli", "Niko", "kolikol", "khaliband", "no@ddl.com", false);
        db.registerUser(user);
    }

    @Test
    public void removeUser() throws SQLException {
        user = new User("loli", "nimo", "kalagh", "worm", "no@ddl.com", false);

        db.removeUser(user);
    }

    @Test
    public void userExists() throws SQLException {
        user = new User("Loli", "Niko", "nimko12", "worm123", "no@ddl.com", false);
        assertEquals( true,db.userExists("nimko12"));
    }

    @Test
    public void validateLogin() throws SQLException {
        String u = "adam";
        String p = "jojrgvc";
        System.out.println(db.validateLogin(u, p));

    }

    @Test
    public void loadWishes() throws SQLException {
        System.out.println(db.loadWishes("kolikol"));

    }

    @Test
    public void registerWish() throws SQLException {
        user = new User("Loli", "Niko", "kolikol", "khaliband", "no@ddl.com", false);
        UserWish wish = new UserWish(user.getID(), "thisBrandNewiPhone", "peiceOfCake");

        db.registerWish(wish.getUsername(), wish.getURL(), wish.getTitle());
    }

    @Test
    public void removeWish() throws SQLException {
        user = new User("loli", "nimo", "hassan", "khaliband", "no@ddl.com", false);
        UserWish wish = new UserWish("niko", "io", "12");

        db.removeWish(wish);
    }


}