# HackDuke2021
## Inspiration
We took a personal interest in this project when a friend who suffers from ADHD struggled to learn personal finance and investment terminology. ADHD kids overall struggle with concentration which leads to challenges in learning. Interactive games have been showed to bolster the concentration and retention span of ADHD kids, helping their learning process. We decided to directly attempt to create a cost-effective application that will work with a phone and Google Cardboard.

## What it does
Finance QuizzAR is an interactive and immersive studying experience, capable of bolstering productivity in a fun and engaging manner. Using a wearable LEAP Motion Sensor, the student can choose the number of questions to be quizzed on, ranging from five to infinite. The question is then shown to the student with large targets surrounding it with the answer choices. The LEAP Sensor tracks hand movement and interacts with environment objects such as a ball, which is thrown towards targets with the answer choices presented on them. Targets flash red and green depending on the correct choice. A score is counted, and the student gets a round of applause at the end of the study session.

## How we built it
To use the LEAP Motion Sensor, we used the Ultraleap plugin for Unity, which allowed us to track the hand movements and position through LEAP Motion Sensor's LIDAR technology extremely accurately. We then created scenes that included collision boxes around objects and a physics engine through Unity's rigid-body component. To code the script for respawning, hand gestures, and question management, we used C# and created different classes for different objects, such as the Board and Ball. We used different scenes to also improve UI and UX design.

## Challenges we ran into
Initially, we were working on implementing this concept in AR. However, due to some problems with managing anchor points, we decided to focus on a prototype VR application. We also had some problems with the actual hand gestures and control of the ball, since the hand motion and ball grabbing physics were initially very sensitive. We fixed this by adding many constraints to the control and movement of the ball.

## Accomplishments that we're proud of
We are extremely proud of our work with this project, given that we had little to no experience in Unity and C# as a group. We are also extremely glad we were able to integrate LEAP Motion Sensor into the controls of the ball with the physics engine to create an interactive quizzing platform.

## What we learned
We learned a lot about Unity workflow in this project, as well as how hand detection can work with collisions in Unity. We also learned a lot about how to create a comfortable human interaction with code and technology.

## What's next for Finance QuizzAR
Our next steps include possible integration with VR and AR, as well as using LIDAR and MLKits for hand detection rather than just the LEAP Motion Sensor.

## Built With
3d
3dprinting
c#
cad
cv
finance
handset-detection
hardware
leap-motion
physic
scene
unity
vr
