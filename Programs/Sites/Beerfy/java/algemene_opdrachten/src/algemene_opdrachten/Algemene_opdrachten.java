package algemene_opdrachten;

/**
 *
 * @author Berend
 */
import java.util.Scanner;

public class Algemene_opdrachten {

    //opdracht 1
    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {

        while (true) {
            int a = 0;
            int b = 1;
            String num;
            System.out.print("Voer het aantal herhallingen in: ");

            num = in.next();
            int x = Integer.parseInt(num);
            for (int i = 1; i <= x; i++) {
                a = a + b;
                b = a - b;
                System.out.print(a + " ");
            }

            System.out.println();
        }

    }
}
