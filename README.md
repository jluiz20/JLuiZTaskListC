# Welcome to JLuiZ TaskList Web API

Here you'll find the documentation and the code for the TaskList created by JLuiZ

The tasklist is composed of the following functionalities:
- Add a New Task; - Modify a Task; 
- Change the status of task, to done or undone; 
- Delete a task; 
- List all tasks; 
- List an especific task; 
- List tasks by its status;

Developed using Visual Studio 2015 Community with SQL Server Express 2014.
Used EntityFramework for object-relational mapper and it's developed in C#.
Versioned with Git.
Commands send with AplicativoAdvanced REST client chrome extention.

Let's get started with the best part!

The home Page
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/Home.png)

Clicking in API you'll have acess to the API documentation
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/API.png)

The methods are:

##GET api/TaskItems
	
Returns all the task unfiltered
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListAll01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListAll02.png)

##GET api/TaskItems?done={done}

Get only the tasks with the desired status
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListByStatus01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListByStatus01.png)

##GET api/TaskItems/{id}
	
Get an specific task by it's Id.
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListByID01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskListByID02.png)

##PUT api/TaskItems/{id}

Updates the task
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskUpdate01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskUpdate02.png)

##POST api/TaskItems/{id}?done={done}

Updates the status to done or undone of an specific task
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskUpdateStatus01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskUpdateStatus02.png)

##POST api/TaskItems

Inserts a new Task in the list
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskInsertNew01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskInsertNew02.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskInsertNew03.png)

##DELETE api/TaskItems/{id}

Deletes a specific task by the ID
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskDelete01.png)
![alt tag](https://github.com/jluiz20/JLuiZTaskListC/blob/master/Images/TaskDelete02.png)

Hope you like it! 
JLuiZ- João Luiz Vieira
