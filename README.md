# quiz-game
Simple quiz game for learning Unity UI
 
 Questions are set as a scriptable object using the following format:
 - Question Text
 - 4x answer options
 - correct answer option (index 0 to 3 related to the correct answer button from top to bottom)
 
 To add new questions:
  - Right-click in the Questions folder, select Create > Quiz Question (repeat for each new question to add)
    Select all new questions in the Questions folder, and drag to QuizCanvas > (inspector) Questions
    
 To remove questions:
   - QuizCanvas > (inspector) Questions > select question/element > click the minus (-) button
   
 To modify questions:
  - Questions folder > Select Question > (inspector) change question text/answer/correct answer field(s)
    - Correct answer uses the Element [index] (default range 0 to 3)
   
 To modify timer settings:
  - Select (object) Timer > (inspector) Timer (Script)
    - Time to Complete Question (How long does player have to respond)
    - Time to Show Correct Answer (How long does the player have to review the current question's correct answer)
              **Note: Ignore all other settings, they are controlled by game's scripts**
 
