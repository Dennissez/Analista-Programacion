import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class MyWorld extends World
{

    /**
     * Constructor for objects of class MyWorld.
     * 
     */
    public MyWorld()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(600, 400, 1); 
        prepare();
    }
    
    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        Estrella estrella = new Estrella();
        addObject(estrella,100,93);
        Estrella estrella2 = new Estrella(30, 5);
        addObject(estrella2,484,317);
        Langosta langosta = new Langosta(10, -20);
        addObject(langosta,64,202);
        langosta.setLocation(61,169);
        Langosta langosta2 = new Langosta(5, 25);
        addObject(langosta2,58,239);
        Langosta langosta3 = new Langosta(-15, -5);
        addObject(langosta3,558,166);
        Langosta langosta4 = new Langosta(-10, 40);
        addObject(langosta4,556,237);
        langosta.turn(-45);
        langosta2.turn(30);
        langosta3.turn(-90);
        langosta4.turn(180);
    }
}
