// Mindfulness program

// From here you will abel to choose how to interact 
// with the program and what you want to do.
// ===============================
//           Controller
// -------------------------------
//     - string  
// -------------------------------
//     + Menu
//     + Switch
// ===============================

// This is where the building and writhing out of new goals will take place on the base. 
// All new goals will be added through here and will be called from the sub classes.
// ===============================
//          Goals : Base
// -------------------------------
//     - string Activity 
//     - string Description 
//     - int time frame 
// -------------------------------
//     + Activity compiler 
//     + Start method
//     + End method 
// ===============================

// This class wil control all the simple goal tasks.
// ===============================
//            Simple
// -------------------------------
//     - string 
//     - 
// -------------------------------
//     + Points compiler 
//     + Start method
// ===============================

// This class wil control all the eternal goal tasks.
// ===============================
//             Eternal
// -------------------------------
//     - string 
// -------------------------------
//     + Points compiler 
//     + Start method
// ===============================

// This class wil control all the checklist goal tasks.
// ===============================
//           Checklist
// -------------------------------
//     - string 
// -------------------------------
//     + Display
//     + Points compiler 
//     + Start method
// ===============================

// Here we want to control how the points work and were they all come from.
// ===============================
//          Points
// -------------------------------
//     - int completionPoints 
//     - int bonusPoints
//     - int extraPoints
// -------------------------------
//     + Points compiler 
//     + addPoints method
// ===============================