# Code by game element
Taking a look at what code is attached to each game element and how it's used.

## Obstacles
  ### Pillar
  - AkGameObj.cs*
  - AkAmbient.cs*
    
  ### Ball
  - [BallMovement.cs](#ballmovementcs)
  - AkGameObj.cs*
  - AkAmbient.cs*

## Goals
  ### Goal
  - [GoalBehavior.cs](#goalbehaviorcs)
  - AkGameObj.cs*
  

## Player
### **FirstPersonController**
  - [FirstPersonController.cs](#firstpersoncontrollercs)
  - [CollisionTracker.cs](#collisiontrackercs)
  - [OOF.cs](#oofcs)
  - AkListenerDistanceProbe.cs*
> [!NOTE]
> Ak Scripts are part of the Wwise library, which there is already documentation for*

# Code by class
Taking a look at each file, class and method individually and much more in depth. While depth is a core component of this, due to the formating of the document, AVOID PUTTING CODE HERE PLEASE.
## OOF.cs
> **Attached To:** [FirstPersonController](#firstpersoncontroller) </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 

    
  - ### Update()
    > **Refrenced By:** 


  - ### OnTriggerEnter(Collider other)
    > **Refrenced By:** 


  - ### OnCollisionEnter(Collision other)
    > **Refrenced By:** 


  - ### ActivateGoal(Collider other)
    > **Refrenced By:** 


  - ### LevelComplete()
    > **Refrenced By:** 


  - ### SelectRandomLevel()
    > **Refrenced By:** 


  - ### resetLevel()
    *yes, with a lowercase 'r'*
    > **Refrenced By:** 
  
  - ### OnApplicationQuit()
    > **Refrenced By:** 
    



## WallSound.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 


## GoalBehavior.cs
> **Attached To:** [Goal](#goal) </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 

  - ### Update()
    > **Refrenced By:** 
    
  - ### FixedUpdate()
    > **Refrenced By:** 
    
  - ### Deactivate()
    > **Refrenced By:** 
    


## BallMovement.cs
> **Attached To:** [Ball](#ball) </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    
  - ### FixedUpdate()
    > **Refrenced By:** 
    
  - ### OnCollisionEnter(Collision collision)
    > **Refrenced By:** 
    
  TODO add editor stuffs here



## SoundsForGoal.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    
  - ### OnTriggerEnter(Collider other)
    > **Refrenced By:** 
    


## BallGenerator2.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    
  - ### Generate()
    > **Refrenced By:** 
    


## CollisionDetect.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### OnCollisionEnter(Collision collision)
    > **Refrenced By:** 
    


## CollisionTracker.cs
> **Attached To:** [FirstPresonController](#firstpersoncontroller) </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    
  - ### FixedUpdate()
    > **Refrenced By:** 
    
  - ### OnCollisionEnter(Collision collision)
    > **Refrenced By:** 
    
  - ### OnTriggerEnter(Collider other)
    > **Refrenced By:** 
    
  - ### WriteToCSV()
    > **Refrenced By:** 
    


## GenerateObstacle.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    


## BallInitialVelocity.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    
  - ### FixedUpdate()
    > **Refrenced By:** 
    
  - ### OnCollisionEnter(Collision collision)
    > **Refrenced By:** 
    
  TODO Editor stuff here (again)


## FirstPersonController.cs
> **Attached To:** [FirstPersonController](#firstpersoncontroller) </br>
> **Refrenced By:** 

  - ### Update()
    > **Refrenced By:** 
    
  - ### FixedUpdate()
    > **Refrenced By:** 
    
  - ### CheckGround()
    > **Refrenced By:** 
    
  - ### Jump()
    > **Refrenced By:** 
    
  - ### Crouch()
    > **Refrenced By:** 
    
  - ### HeadBob()
    > **Refrenced By:** 
    
  TODO Editor stuff here (again again)


## EnviromentGeneratorPrefab1.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    


## EnviromentGeneratorPrefab2.cs
> **Attached To:** </br>
> **Refrenced By:** 

  - ### Start()
    > **Refrenced By:** 
    
  - ### Update()
    > **Refrenced By:** 
    


