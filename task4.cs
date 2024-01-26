
while(AtGoal = false)
{
    if(Intersection = true)
    {
        if(Peek_2_Cell = true)
        {
            Move();
        }
        else
        {
            Turn();
            Move();
        }
    }
    else if(Peek_1_Cell = false)
    {
        Turn();
        Move();
    }
    else if(Trail = true)
    {
        Turn();
        Move();
    }
    else
    {
        Move();
    }
}


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Trail()
{
    // Returns true if you turn to a cell you have already been on.
    return true; // Just a placeholder value. 
}

bool Peek_1_Cell()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool Peek_2_Cell()
{
    // Returns true if there are two consecutive open cells.
    return true; // Just a placeholder value. 
}

bool Intersection()
{
    // Returns true if there are more than one open cell next to current cell.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion
