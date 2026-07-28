import greenfoot.*;  

public class Edificio extends Actor
{
    private int cantidadPisos;
    private int cantidadDepartamentos;
    private String constructora;
    private boolean esHabitable;

    public Edificio(){
        this.cantidadPisos = 1;
        this.cantidadDepartamentos = 1;
        this.constructora = "";
        this.esHabitable = false;
    }

    public Edificio(int cantidadPisos, int cantidadDepartamentos, 
                    String constructora, boolean esHabitable){
        this.cantidadPisos = cantidadPisos;
        this.cantidadDepartamentos = cantidadDepartamentos;
        this.constructora = constructora;
        this.esHabitable = esHabitable;
    }
    
    public int getCantidadPisos(){
        return this.cantidadPisos;
    }
    
    public int getCantidadDepartamentos(){
        return this.cantidadDepartamentos;
    }
    
    public String getConstructora(){
        return this.constructora;
    }
    
    public boolean getEsHabitable(){
        return this.esHabitable;
    }
    
    public void setCantidadPisos(int cantidadPisos){
        this.cantidadPisos = cantidadPisos;
    }
    
    public void setCantidadDepartamentos(int cantidadDepartamentos){
        this.cantidadDepartamentos = cantidadDepartamentos;
    }
    
    public void setConstructora(String constructora){
        this.constructora = constructora;
    }
    
    public void setEsHabitable(boolean esHabitable){
        this.esHabitable = esHabitable;
    }
    
    public int totalDepartamentos(){
        return this.cantidadDepartamentos * this.cantidadPisos;
    }
    
    public String analizar(){
        String retorno = "";
        retorno = "Deptos x piso: " + this.cantidadDepartamentos;
        retorno = retorno + " | Cantidad de pisos: " + this.cantidadPisos;
        retorno = retorno + " | Total departamentos: " + this.totalDepartamentos();        
        return retorno;
    }
    
    public void act()
    {
        // En esta sección se incluyen las acciones que se realizarán
        // al presionar el botón Accionar o Act
    }
}
