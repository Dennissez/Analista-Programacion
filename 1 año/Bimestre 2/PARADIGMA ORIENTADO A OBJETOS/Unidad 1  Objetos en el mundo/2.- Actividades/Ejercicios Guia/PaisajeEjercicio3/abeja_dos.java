import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Clase Abeja
 */
public class abeja_dos extends Actor
{
    private int anios;
    private String panal;
    
    public abeja_dos()
    {
    anios = 0;
    panal = "Panal 1";
    } 
    
    // Constructor con parámetros
    public abeja_dos(int anios, String panal)
    {
        this.anios = anios;
        this.panal = panal;
    }

    // Getter años
    public int getAnios()
    {
        return anios;
    }

    // Getter panal
    public String getPanal()
    {
        return panal;
    }

    // Setter años
    public void setAnios(int anios)
    {
        this.anios = anios;
    }

    // Setter panal
    public void setPanal(String panal)
    {
        this.panal = panal;
    }
    
    public void act()
    {
        // Add your action code here.
    }
}
