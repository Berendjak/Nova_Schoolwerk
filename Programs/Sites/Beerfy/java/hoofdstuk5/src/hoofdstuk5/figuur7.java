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
public class figuur7 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int spatie = '\n';
        for (int regel = 1; regel <= 5; regel++) {
            for (int kolom = 1; kolom <= (0 + regel); kolom++) {
                for( spatie = 5; spatie < (5+spatie); spatie++)
                System.out.print("*");
            }
            //for
            System.out.println();
        }

        
    }
}
