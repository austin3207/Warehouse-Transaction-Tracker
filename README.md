# Warehouse-Transaction-Tracker

Purpose of this project was to design a simple system that updates warehouse inventory
based on the provided transactions. It prioritizes the warehouse with the largest
inventory of the specified part for any sells. Warehouses with the smallest amount 
of the specified part are prioritized for any purchases. 

The initial state is stored in a text file which is read at 
the start of the program. The transactions are pulled from 
a text file and stored in an array as Strings. Each String is 
then split into the 3 pieces of information needed for each
transaction(Purchase/Sell, Part ID, Number of Parts).

Basic User Experience
Step 1.
The initial state is output to the console. Includes the warehouse name and current
inventory.

Step 2.
Each transaction is output to the console and includes which warehouse was chosen.

Step 3.
Outputs the final inventory of each Warehouse.
