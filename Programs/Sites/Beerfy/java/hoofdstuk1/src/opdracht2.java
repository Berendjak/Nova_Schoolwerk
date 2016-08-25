
import java.util.Scanner;
/**
 *
 * @author Berend
 */
public class opdracht2 {

    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args){

        while (true) {
            System.out.println("\nVul een getal in: ");
            String num = in.next();
            int c = Integer.parseInt(num);
            int uitkomst = 1;
            for(int a = c; a > 1; a--){
                uitkomst = uitkomst * a;
                System.out.print(a + " x ");
            }
            System.out.println("1 = " + uitkomst);
        }
    }
}


