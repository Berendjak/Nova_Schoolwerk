/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hoofdstuk6;
import java.io.*;
/**
 *
 * @author Berend
 */
public class Opdracht2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        String a;
        
        System.out.print("Typ een getal groter dan 1: ");
        a = br.readLine();
        
        int tot = Integer.parseInt(a);
        
        for(int num = 1; num < tot; num++){
            System.out.println(num);
            //if(num==a)break;
            
        }
            
    }
    
}
