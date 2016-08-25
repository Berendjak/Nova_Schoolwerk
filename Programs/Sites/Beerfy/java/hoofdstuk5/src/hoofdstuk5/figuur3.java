/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hoofdstuk5;

/**
 *
 * @author Berend
 */
public class figuur3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        for (int regel = 1; regel <= 5; regel++) {
            for (int kolom = 1; kolom <= (6 - regel); kolom++) {
                System.out.print("*");
            }
            System.out.println();
        }
    }
}
