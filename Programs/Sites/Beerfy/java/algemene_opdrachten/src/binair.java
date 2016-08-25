import java.util.Scanner;
/**
 *
 * @author Berend
 */
public class binair {
    public static Scanner in = new Scanner(System.in);
    public static void main(String[] args) {
        System.out.print("Vul een binaire code in: ");
        String nums = in.next();
        int num = Integer.parseInt(nums);
        int a = 0;
        for(int b = 1; num>0; b++){
            num/=2;
            a = num % 2;
            System.out.print(num);
            
        }
    }
    
}
