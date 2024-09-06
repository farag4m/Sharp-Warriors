# Code by game element
Taking a look at what code is attached to each game element and how it's used.

## Obstacles
  ### Pillar
  - AkGameObj.cs*
  - AkAmbient.cs*
    
  ### Ball
  - [BallMovement.cs](#BallMovement.cs)
  - AkGameObj.cs*
  - AkAmbient.cs*

## Goals
  ### Goal
  - [GoalBehavior.cs](#GoalBehavior.cs)
  - AkGameObj.cs*
  

## Player
### **FirstPersonController**
  - [FirstPersonController.cs](#FirstPersonController.cs)
  - [CollisionTracker.cs](#CollisionTracker.cs)
  - [OOF.cs](#OOF.cs)
  - AkListenerDistanceProbe.cs*
> [!NOTE]
> Ak Scripts are part of the Wwise library, which there is already documentation for*

# Code by class
Taking a look at each file, class and method individually and much more in depth

## OOF.cs
  ### Start()
  ### Update()
  ### OnTriggerEnter(Collider other)
  ### OnCollisionEnter(Collision other)
  ### ActivateGoal(Collider other)
  ### LevelComplete()
  ### SelectRandomLevel()
  ### resetLevel()
*yes, with a lowercase 'r'*
  ### OnApplicationQuit()



## WallSound.cs
  ### Start()


## GoalBehavior.cs
  ### Start()
  ### Update()
  ### FixedUpdate()
  ### Deactivate()


## BallMovement.cs
  ### Start()
  ### Update()
  ### FixedUpdate()
  ### OnCollisionEnter(Collision collision)
  TODO add editor stuffs here



## SoundsForGoal.cs
  ### Start()
  ### Update()
  ### OnTriggerEnter(Collider other)


## BallGenerator2.cs
  ### Start()
  ### Update()
  ### Generate()


## CollisionDetect.cs
  ### OnCollisionEnter(Collision collision)


## CollisionTracker.cs
  ### Start()
  ### Update()
  ### FixedUpdate()
  ### OnCollisionEnter(Collision collision)
  ### OnTriggerEnter(Collider other)
  ### WriteToCSV()


## GenerateObstacle.cs
  ### Start()
  ### Update()


## BallInitialVelocity.cs
  ### Start()
  ### Update()
  ### FixedUpdate()
  ### OnCollisionEnter(Collision collision)
  TODO Editor stuff here (again)


## FirstPersonController.cs
  ### Update()
  ### FixedUpdate()
  ### CheckGround()
  ### Jump()
  ### Crouch()
  ### HeadBob()
  TODO Editor stuff here (again again)


## EnviromentGeneratorPrefab1.cs
  ### Start()
  ### Update()


## EnviromentGeneratorPrefab2.cs
  ### Start()
  ### Update()


