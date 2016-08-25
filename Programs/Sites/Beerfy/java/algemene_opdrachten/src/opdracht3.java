
import java.util.Scanner;

/**
 *
 * @author Berend
 */
public class opdracht3 {

    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {

        while (true) {
            int uit;

            System.out.println("\nVul het getal in: ");
            int num = in.nextInt();
            System.out.println("Vul de macht in: ");
            int macht = in.nextInt();
            System.out.println(Math.pow(num, macht));
            }
        }
    }

