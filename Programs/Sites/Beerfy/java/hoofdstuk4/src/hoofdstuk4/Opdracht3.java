/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hoofdstuk4;

/**
 *
 * @author Berend
 */
public class Opdracht3 {

    public static void main(String[] args) {
        int a;
        a = -1;
        if ((a <= 5.5) && (a >= 0)) {
            System.out.println("Onvoldoende!");
        } else if ((a <= 10) && (a >= 0)) {
            System.out.println("Voldoende!");
        } else {
            System.out.println("Foute input!");
        }
    }
}
