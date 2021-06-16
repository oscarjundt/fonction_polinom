using System;
class rose{
    static void Main(){
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        affichage(a,b,c);
    }
    public static void affichage(double x, double y, double z){
        double cc = alpha(x,y,z);
        Console.WriteLine(cc);
        double cc3 = beta(cc,x,y,z);
        Console.WriteLine(cc3);
        double cc4 = discri(x,y,z);
        Console.WriteLine(cc4);
    }
    public static double alpha(double x2, double y2, double z2){
        double cc2 = (-y2)/(2*x2);
        return cc2;
    }
    public static double beta(double xx, double x3, double y3, double z3){
        double res = (x3*(xx*xx))+(y3*(xx))+z3;
        return res;
    }
    public static double discri(double x4, double y4, double z4){
        double res2 = (y4*y4)-(4*(x4)*(z4));
        return res2;
    }
}