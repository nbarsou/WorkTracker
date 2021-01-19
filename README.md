# WorkTracker
A program that runs in terminal (For now) that helps you track tasks and the time spent on them. This is also my first GitHub project, so if you have any recommendations or tips feel free to give them. Any feedback and interaction is welcomed! 

## Requirements  
    - Very light program to run in background
    - Easy to Use 
    - Fast to Use  
    - Intuative to use 

## TODO 
    - Functions:
        - Tasks: 
            - Function to Create a Task/SubTask: Ask for Task/Sub Name, ask for Task/Sub Description, then store in Memory, finally open the Task menu or Return to Task Menu. 

            - Function to Select a Task/SubTask: Open the Task Menu for the spefic Task. 

            - Function to Edit a Task/SubTask: Display the Name, Prompt for changes, Display the Description, Prompt for Changes. 

            - Function to Complete a Task/Subtask: Set Task/Sub status from [PENDING] to [DONE], if TimeTrack is Active then get time to completion, store the data. 

            - Function to Delete a Task/SubTask: Prompt The User, Prompt Confirm, If Comfirm then Delete fron Memory. 
        
        -TimeTrack: 
            -Function to Start TimeTrack: Get Current Time, Set CurrentTime as TimeStart. If a Task is not Selected, then set ActiveTask as TaskManaging. 

            - Function to Change ActiveTask: If a Task is Selected, Get CurrentTime, Get TimeOnActiveTask (CurrentTime - TimeStart), Store This to ActiveTask, Set SelectedTask to ActiveTask, CurrentTime to TimeStart.  

            -Function to Mark as Done: If Task/Sub Marked as Done, Get CurrentTime, Get TimeOnActiveTask, Store This to Task/Sub MetaData, If Task marked done: Set SelectedTask to TaskManaging, CurrentTime to TimeStart. Store to Memory. 
    
## Functionality 
    - Create a task
    - Create subtaks 
    - Time Track 
    - When done with a subtask register time of completion (While in time tracking mode, 
    select the number of subtask then hit enter)
    - When done with time tracking (Enter some quick text describing what you did)

## Extra Functionality: 
    - General Stats 
    - Stats for each Categories / Projects  
    - Set workhours* 
    - Give Desktop Notifications 
    - Detect AFK 

    *Need to find a way to do this while keeping the program light 
