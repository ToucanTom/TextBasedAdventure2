using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public Text textObject;
    bool hasBar;
    bool sword;
    bool ran;
    

    public enum States {
        start,
        bed,
        window_0, window_1,
        door_0, door_1,
        table_0, table_1,
        hallway,
        freedomDoor_0, freedomDoor_1
     };

    public States currentState;

    // Use this for initialization
    void Start()
    {
        currentState = States.start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (States.start):
                hasBar = false;
                sword = false;
                ran = false;
                State_Start();
                break;
                //bed
            case (States.bed):
                State_Bed();
                break;
                //window
            case (States.window_0):
                State_Window_0();
                break;
            case (States.window_1):
                State_Window_1();
                break;
                //door
            case (States.door_0):
                State_Door_0();
                break;
            case (States.door_1):
                State_Door_1();
                break;
            //table
            case (States.table_0):
                State_Table_0();
                break;
            case (States.table_1):
                State_Table_1();
                break;
            //hallway
            case (States.hallway):
                State_Hallway();
                break;
            //freedom door
            case (States.freedomDoor_0):
                State_FreedomDoor_0();
                break;
            case (States.freedomDoor_1):
                State_FreedomDoor_1();
                break;
        }

    }

    void State_Start()
    {
        textObject.text = "You awake to find yourself in a crappy bed in what looks like a jail cell. \n" +
            "There is light coming in through the bars of a Window and \n" +
            "A thick wooden Door with a metal lock seals of the room. \n\n" +
            "Press W to go to the Window or D to go to the Door";
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentState = States.door_0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            currentState = States.window_0;
        }
    }

    void State_Bed()
    {
        textObject.text = "Not much to see here, a flat bed with no blankets... \n" +
            "Press D to go to the door, or W to go to the Window.";
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentState = States.door_0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (!hasBar) currentState = States.window_0;
            else currentState = States.window_1;
        }
    }

    void State_Window_0()
    {
        textObject.text = "you can see that their is a thick forest outside of the building." +
            "\n you also notice that one of the Iron Bars on the window is loose. \n" +
            "Press: I to try to take the Iron Bar, D to go to the Door, or B to go back to your Bed";
        if (Input.GetKeyDown(KeyCode.I))
        {
            hasBar = true;
            currentState = States.window_1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
             currentState = States.door_0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = States.bed;
        }
    }

    void State_Window_1()
    {
        textObject.text = "You have removed the Bar from the Window. The space between the bars isnt big enough \n" +
            "for you to get out that way, but that bar seems like it could be useful...\n" +
            "Press D to go to the Door or B to return to the Bed.";
        if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = States.bed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            currentState = States.door_0;
        }
    }

    void State_Door_0()
    {
        if (hasBar)
        {
            textObject.text = "You see a very thick wooden door with a rusty metal lock, \n" +
            "in fact it looks like it might break if you could Hit it hard enough. \n" +
            "Press H to hit the lock, B to go back to your Bed, or W to go back to the Window.";
        }
        else
        {
            textObject.text = "You see a very thick wooden door with a rusty metal lock, \n" +
            "in fact it looks like it might break if you could hit it hard enough. \n" +
            "Press B to go back to your Bed, or W to go back to the Window.";
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = States.bed;
        }else if (Input.GetKeyDown(KeyCode.W))
        {
           if(!hasBar) currentState = States.window_0;
           else currentState = States.window_1;
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            currentState = States.door_1;
        }

    }

    void State_Door_1()
    {
        textObject.text = "You made it out of the room! Only to find your next obsticle.\n" +
            "There is a Table with weapons and food just past a sleeping Guard...\n" +
            "You can try to Sneak past him and not wake him or Attack him with you Bar \n" +
            "Press S to Sneak past, or A to Attack";
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentState = States.table_0;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = States.table_1;
        }
    }

    void State_Table_0()
    {
        textObject.text = "You try to sneak past the guard and you trip and knock a weapon off the table. \n" +
            "The guard wakes up and kills you...\n\n" +
            "GAME OVER \n\n" +
            "Press R to reset.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.start;
        }
    }

    void State_Table_1()
    {
        textObject.text = "You walk quitely up to the sleeping guard, and with \n " +
            "only the desire for freedom directing your moral compass, \n" +
            "you raise that Iron bar high and bring it down with the all the strength you can muster.\n" +

            "The guard, now sprawled out on the floor, remains 'unaware' of the world around him, but most importantly, \n " +
            "he is no longer a problem.\n\n" +

            "You make your way over to the Table where you collect a Sword, a Crossbow, \n " +
            " and some food for your travels to the woods. \n" +
            "The only place you can go now is forward. You see a Hallway around the corner. \n\n" +
            "Press H to enter the Hallway";
        if (Input.GetKeyDown(KeyCode.H))
        {
            currentState = States.hallway;
        }
    }

    void State_Hallway()
    {
        textObject.text = "You find youself staring at a guard, this one is very much awake and aware of you. \n" +
            "Behind him you can see the exit door." +
            "He begins to charge you with his sword drawn, he obviously doesnt want to talk it out. \n" +
            "What do you do?\n\n" +
            "Press R to try to run past him, S to defend yourself with the Sword, or C to shoot him with the Crossbow";
            if (Input.GetKeyDown(KeyCode.R))
        {
            ran = true;
            currentState = States.freedomDoor_0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            sword = true;
            currentState = States.freedomDoor_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentState = States.freedomDoor_1;
        }
    }

    void State_FreedomDoor_0()
    {
        if (ran)
        {
            textObject.text = "You try to run past the charging guard. \n";
        }
        else if (sword)
        {
            textObject.text = "You atempt to block the guards powerful swing, but you just arn't strong enough. \n";
        }

        textObject.text += "The guard brings his sword down ontop of you and cuts you down with relative ease. \n" +
            "GAME OVER \n\n" +
            "Press R to Reset.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.start;
        }
    }

    void State_FreedomDoor_1()
    {
        textObject.text = "Your arrow strikes the oncoming guard right in his freaking eye! Needless to say he died \n" +
            "and you didn't. You make your way to the door behind the guard and out to your freedom! \n\n" +
            "GAME OVER! :) WELL DONE! \n" +
            "Press R to Reset the game.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = States.start;
        }
    }
}
