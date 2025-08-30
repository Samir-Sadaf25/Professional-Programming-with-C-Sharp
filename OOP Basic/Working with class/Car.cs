namespace oop
{ 
    class Car
    {
     public string color;
     double currentSpeed;
    int maxSpeed;
    public bool hasEngineStarted;

    public int CurrentSpeed { get; set; }
    public Car(string color,int maxSpeed)
    {
        this.color = color;
        this.maxSpeed = maxSpeed;
    }
    public Car()
    {
       color = "White";
        maxSpeed = 180;
    }
    public int MaxSpeed
    {
        get {
            return maxSpeed;
         
        }
        set
        {
            maxSpeed = value;
        }
    }
    void start()
    { 
       hasEngineStarted = true;
    }
    void stop()
    { hasEngineStarted = false;
    }
}
}

