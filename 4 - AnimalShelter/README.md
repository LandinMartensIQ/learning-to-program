# Assignment #4 | Animal Shelter

This assignment will test your ability to create code using even more object oriented principals (OOP). Every assignment before this one, tests were provided for you, however it is now time you start to take over all the coding. You know the basic skills to develop in C# at this point and now it is time to take everything you learned and combine it with OOP to develop a small program.

# Requirements Before Starting

* Understanding of the following `(Previous assignment requirements, Inheritance, Polymorphism, Abstraction, Encapsulation)`
* Possibly googling how to do things in C# as you run into roadblocks - this is expected
  * Googling things and doing self research is a core aspect of being a programmer
  * If you still are having a hard time, ask me for help

# Setup Instructions

* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git stash` and hit enter
	* This places any possible changes you have into a cache within git to start you off in a clean state
	* Don't worry, these changes are not gone. You can recover them later if you want with a `git stash pop` command
* Type `git checkout master` and hit enter
* Type `git pull` and hit enter
* Type `git checkout -b <your_name_here_without_arrows>_Assignment_4` and hit enter
* Type `git push -u origin <your_name_here_without_arrows>_Assignment_4` and hit enter
* Open this folder `cd C:\Git\learning-to-program\4 - AnimalShelter` in file explorer
* Open `AnimalShelter.sln` in visual studio 2019

# Assignment Instructions

The goal of this assignment is to create an Animal Shelter program that can take in animals of specific types, expose information about stored animals and eventually give those animals away when requested.

Inside of the solution you just opened you will see a single project with two folders. Inside of the `Code` folder is where you will place the classes and other types you will create. Inside of the `Tests` folder is where you will create your own unit tests to validate the requirements that are to be explained below. I have included a `Tests_Example.cs` that you can use as a template to create your own tests using TDD (Test Driven Design). You should get in the habit of creating tests first for the requirements and then writting code to make the tests pass. TDD often helps create better and cleaner code.

### Requirements

* Create an animal shelter class

	* [AddAnimal]
	* This function will an animal to the shelter
	* Create a public function with an animal object parameter that will return a result object
		* The animal object parameter must be an animal, but can be any animal
			* Known Animals
				* Cat
				* Dog
				* Deer
				* Bear
				* Bird
				* Snakes
		* If the animal is supported, the animal will be stored within the shelter class
			* Supported Animals
				* Cat
				* Dog
				* Bird
				* Snake
			* When an animal is stored, the animal should be marked with a unique id called "UniqueAnimalId"
		* This function will return a result object with the following properties:
			* Property: If the animal was added to the shelter(true / false)
			* Property: The animal object that was added to the shelter (NULL if not added)
			* Property: String error message for reasons the animal was not added
				* Example error messages
					* Animal was not a supported animal
					* Anything else you can think of that you think the system should validate against

	* [GetAnimals]
	* This function will return a list of filtered animals from the animals stored in the shelter class
	* Create a public function with a parameter to represent a filter, this function will return a list of animals
		* Only one filter can be passed in at a time (So one of the four listed below)
		* Filter critera is as follows
			* Animals that can fly
			* Animals that are cats
			* Animals that are dogs
			* All animals, (no filter)

	* [RemoveAnimal]
	* This function will remove an animal from the shelter
	* Create a public function with an animal object parameter that will return a result object
		* The animal object parameter must be an animal, but can be any animal
			* Known Animals
				* Cat
				* Dog
				* Deer
				* Bear
				* Bird
				* Snakes
		* If the animal is supported and the animal is found, the animal will be removed from the shelter class
			* Supported Animals
				* Cat
				* Dog
				* Bird
				* Snake
		* This function will return a result object with the following properties:
			* Property: if the animal was removed (true / false)
			* Property: The animal object that was removed
			* Property: string error message for reasons the animal was not removed
				* Example error messages
					* Animal was not in the system
					* Animal was not a supported type
					* Anything else you can think of that you think the system should validate against

	* [GetAnimalFromId]
	* This function will get an animal based upon the UniqueAnimalId
	* Create a public function with an UniqueAnimalId parameter that will return a result object
		* This function will return a result object with the following properties:
			* Property: if the animal was found (true / false)
			* Property: The animal object that was found
			* Property: string error message for reasons the animal was not found
				* Example error messages
					* Id is not a valid format
					* Animal does not exist in the system
					* Anything else you can think of that you think the system should validate against

### Try to come up with test cases that pushes your code to try to find bugs, edge cases, weird logic or exceptions. These test cases should be represented by one or more unit tests. Assume this animal shelter class was a public API - how could people use, abuse or missuse the system?

# Submission Instructions

* When you are done and ready for review you need to push your changes so I can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git commit -m "Code For Assignment"` and hit enter
* Type `git push` and hit enter
* Let me know which assignment you have done and I will take a look and review it
