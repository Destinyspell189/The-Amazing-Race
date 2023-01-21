
Name: Kennedy Middlebrooks 

Logic Walkthrough: 

- The algorithm provided consists of one class and one recursive method PathFinder in the class Maze Runner
- The recursive method checks for a path where the next line at that index is a 1 if not it assumes neighborhing paths
- The path printed is only done so if the program is sure there is a continuing path. 

PathFinder(path, routesLeft, lastIndex, arrNum)
Path = string for representing a single line.
routes left = the total number of lines expected to comb through left (to avoid exception error)
last Index = an optional integer to keep track of where the last path index was. This ensures That paths are toughing without backtracking
ArrNum = an optional integer that gives the number of paths (strings) already checked (excluded when staying on the same path)


A few comments and concerns this program misses: 
- In the example there were a a few ambiguous correlations between the picture and the output given. 
- This algorithm may be blind to cases in which there is no path/ it stops after the enterance for some reason. This is because it assumes 
at least one sibling node to be correct if all others have failed. 

The below is my Initial Scratch Design thinking: 

maze finder thing 

what do I need to know? 

how many lines there are in total *when ill reach the end*

basic algorithm logic:
- we are searching for a 1 down. If the one is not under this one we look
for the other ones to the left and right. 
- the one also has to connect to the top one. 

Recursive plan: 
- takes in array and num array left, optional value with default
parameter prev index = 0, (lines left to go through) 
- returns on base case (empty done message) 
- end on the case that theres only one line left to search (cause already found)
- search for every occurence of 1 in the array and temp store their index
- the index with a 1 on the next line is correct 
- if the index with a 1 on the next line and the index of the prev dont match,
print the steps of the indexes between (check right or left) 
	- IF next line is 1 at same pos (do recursion call)
	- IF not then check left then right for 1 at that index 
	- check for next line 1 on either of those 
	- print findings and do call from that point 
returns an integer (the index lol)
