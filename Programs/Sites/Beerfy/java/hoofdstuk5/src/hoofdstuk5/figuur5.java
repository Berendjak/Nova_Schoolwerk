package hoofdstuk5;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Berend
 */
public class figuur5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        for (int regel = 1; regel <= 5; regel++) {
            for (int kolom = 0; kolom < regel; kolom++) {
                System.out.print(regel);
            }
            System.out.println();
        }
    }
}