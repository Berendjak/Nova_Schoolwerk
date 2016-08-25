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
public class Hoofdstuk6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        String input;
        
        System.out.print("Typ hier je naam: ");
        input = br.readLine();
        System.out.println("Hallo " + input);
    }
    
}
