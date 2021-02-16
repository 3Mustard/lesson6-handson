Lesson 6 Hands-On45 points
Directions
In the lesson, we went over creating web API applications that can send and receive data. For this hands-on, create a Web API project that takes data from a front end (Postman), passes the information to the Web API, and then stores the data in an SQLite database. The object passed by the API should be a model called Car. Please zip your project directory and upload when you are finished. This Hands-On will be graded, so be sure you complete all requirements.

Requirements:
One Post action method that:
takes in Car
Saves Car to the database
Get Method to get all cars
Get by Id method to get a specific car
Check if a car already exists and update the current record if true
Create a get method that will only show cars where the number of passengers is less than 3
Order the list by newest Year first, before sending back to the client.
Car Model:

Id
Year
Make
Model
Number of passengers
