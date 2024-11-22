import org.junit.jupiter.api.Assertions;
import classes.GenZHelper;
//import java.util.ArrayList;

public class GenZTest {
    // Your code starts here
    @org.junit.jupiter.api.Test
    void Test1997() {
        Assertions.assertEquals(true, GenZHelper.IsGenZ(1997));
    }

    @org.junit.jupiter.api.Test
    void Test1998() {
        Assertions.assertEquals(true, GenZHelper.IsGenZ(1998));
    }

    @org.junit.jupiter.api.Test
    void Test1996() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(1996));
    }

    @org.junit.jupiter.api.Test
    void Test2015() {
        Assertions.assertEquals(true, GenZHelper.IsGenZ(2015));
    }

    @org.junit.jupiter.api.Test
    void Test2016() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(2016));
    }

    @org.junit.jupiter.api.Test
    void Test2014() {
        Assertions.assertEquals(true, GenZHelper.IsGenZ(2014));
    }

    @org.junit.jupiter.api.Test
    void TestMinValue1() {
        Assertions.assertThrows(IllegalArgumentException.class, () -> GenZHelper.IsGenZ(Integer.MIN_VALUE));
    }

    @org.junit.jupiter.api.Test
    void TestMinValue() {
        Assertions.assertThrows(IllegalArgumentException.class, () -> GenZHelper.IsGenZ(Integer.MIN_VALUE + 1));
    }

    @org.junit.jupiter.api.Test
    void TestMaxValue() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(Integer.MAX_VALUE - 1));
    }

    @org.junit.jupiter.api.Test
    void TestMaxValue1() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(Integer.MAX_VALUE));
    }

    @org.junit.jupiter.api.Test
    void Test1581() {
        Assertions.assertThrows(IllegalArgumentException.class, () -> GenZHelper.IsGenZ(1581));
    }

    @org.junit.jupiter.api.Test
    void Test1582() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(1582));
    }

    @org.junit.jupiter.api.Test
    void Test1583() {
        Assertions.assertEquals(false, GenZHelper.IsGenZ(1583));
    }
    // Your code ends here
}
