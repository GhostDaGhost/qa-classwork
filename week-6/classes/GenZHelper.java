package classes;

// 'WOULD-BE' CLASS
public class GenZHelper {
    public static boolean IsGenZ(int year) throws IllegalArgumentException {
        if (year < 1582) {
            throw new IllegalArgumentException();
        }
        return (year >= 1997 && year <= 2015) ? true : false;
    }
}
