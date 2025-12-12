# 🍎 Apple Picker (CS382 Game Design, Development & Technology)

- **Play Online (WebGL):** https://zunehrabanu.github.io/Banu_ApplePicker/
- **GitHub Repository:** https://github.com/zunehraBanu/Banu_ApplePicker

---

## 🎯 Overview
**Apple Picker** is a Unity game developed for **CS382 – Game Design, Development, and Technology**, based on the Apple Picker tutorial from **Bond Chapter 29**.  
The player controls a basket using the mouse to catch falling apples while avoiding dangerous objects. The game includes multiple rounds, a start screen, score tracking, and a WebGL deployment hosted on GitHub Pages.

---

## 🧩 Project Requirements (from course)

### **✔ Base Requirement**
- Completed the **Apple Picker tutorial from Bond Chapter 29**

### **✔ Graded Criteria**
| Requirement | Points | Status |
|------------|--------|--------|
| Start screen with Start button | 1 pt | ✔ Implemented |
| Increase baskets from 3 to **4** | 1 pt | ✔ Implemented |
| UI showing **Round 1 → Round 4 → Game Over** | 1 pt | ✔ Implemented |
| Restart button on Game Over | 1 pt | ✔ Implemented |
| Bad falling object (Black Apple) | 1 pt | ✔ Implemented |

---

## 🧩 Features & Implementation

### **✔ Tutorial Foundation**
- Implemented using **Bond Chapter 29**
- Includes apple spawning, basket movement, collisions, scoring, and basket removal

### **✔ Correct Unity Version**
- **Unity 2021.3.33f1 (LTS)**  
- Matches textbook and course compatibility

### **✔ Basket & Scoring System**
- Player controls the basket using mouse movement
- Catching apples increases score
- Missing apples removes baskets
- Game ends when all baskets are lost

---

## 🔄 Round System (Round 1 → Round 4)

Rounds represent **progressive difficulty** based on the number of remaining baskets.

- **Round 1:** 4 baskets available  
- **Round 2:** 3 baskets remaining  
- **Round 3:** 2 baskets remaining  
- **Round 4:** 1 basket remaining  

As baskets are lost, the round number updates automatically and difficulty increases naturally by reducing the margin for error.

- The current round is displayed at the top of the screen
- When all baskets are lost, the game displays **Game Over**

---

## ⚠️ Bad Falling Object (Black Apple)

### **✔ Black Apple Behavior**
- Falls less frequently than normal apples
- Catching a black apple immediately triggers **Game Over**
- Missing a black apple does **not** penalize the player

> **Note:**  
> The black apple spawn probability is set slightly higher during testing to ensure visibility during evaluation. This value can be reduced for standard gameplay.

### **✔ Implementation Details**
- Uses probability-based spawning
- Separate logic from normal apples
- Clear visual distinction using a black material

---

## 🎮 How to Play
1) Move the basket using the mouse  
2) Catch red apples to increase your score  
3) Avoid the black apples  
4) Missing apples removes baskets  
5) Game ends when all baskets are gone  
6) Click **Restart** to play again  

---

## 🌐 Web Deployment
- Game is built using **Unity WebGL**
- Hosted using **GitHub Pages**
- Playable directly in the browser without downloads

---

## 👤 Author
**Syeda Zunehra Banu**  
CS382 – Game Design, Development & Technology  
Southern Illinois University Edwardsville

