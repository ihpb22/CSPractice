namespace Secao4;

class Triangulo {
    private double ladoX;
    private double ladoY;
    private double ladoZ;

    public Triangulo(double x, double y, double z){
        this.setX(x);
        this.setY(y);
        this.setZ(z);
    }
    
    private void setX(double x){
        this.ladoX = x;
    }

    private void setY(double y){
        this.ladoY = y;
    }

    private void setZ(double z){
        this.ladoZ = z;
    }

    public double getX(){
        return this.ladoX;
    }

    public double getY(){
        return this.ladoY;
    }

    public double getZ(){
        return this.ladoZ;
    }

    public double CalcArea (){
        double p = (this.getX() + this.getY() + this.getZ())/2;
        return Math.Sqrt(p*(p-this.getX())*(p-this.getY())*(p-this.getZ()));
    }
}