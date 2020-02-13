# AR Art Project

![pheonixcard.jpg](https://www.dropbox.com/s/6t4lvcc0zchqtsf/pheonixcard.jpg?dl=0&raw=1)

##### What is Augmented Reality?
AR or Augmented Reality is an interactive experience of a real-world environment where the objects that reside in the real world are computer generated perceptual information. 

--------------------------------------

##### About the project
This project is about creating an AR Experience using Unity and Vuforia.
For my AR Experience I wanted to have a virtual creature to fly above a card.
I used a model from [NORBERTO-3D](https://sketchfab.com/3d-models/phoenix-bird-844ba0cf144a413ea92c779f18912042) on Sketchfab. The model already had textures and animations rigged. 
For the stars I used the particle system built into Unity. I changed it's properties to get the right look I wanted. 

--------------------------------------

##### Design Process
I always liked the idea of having a virtual animal in AR and I like phoenix's. So I implemented the Phoenix into the project and used particles to add a fire/space effect

--------------------------------------

##### Building the Game

For this project we used the Vuforia Engine. It allows you to create Augmented Reality Apps within Unity. It also supports AR App Development for mobile devices.
To display the target image you have to upload it to a database on Vuforia Development Website. To create the database you need to get a license.

![arss2.png](https://www.dropbox.com/s/s4fc9dpqj4wb9ns/arss2.png?dl=0&raw=1)

Once you got a license for the project you can create the database.

![arss6.png](https://www.dropbox.com/s/qcibo26otheda42/arss6.png?dl=0&raw=1)

Next you can upload a target image to be recognised.![Screenshot 2020-02-13 at 14.21.17.png](https://www.dropbox.com/s/lnr428oklub0gpr/Screenshot%202020-02-13%20at%2014.21.17.png?dl=0&raw=1)

Once you have selected your image it will be added to the database, then you can download the database and import it into Unity.

![arss1.png](https://www.dropbox.com/s/drz6bih5tpsq5vs/arss1.png?dl=0&raw=1)

Once you import the database you can add an image target object to the scene and select the image you uploaded to the database. That will be the image that is picked up by the AR Camera Object. 

![arss4.png](https://www.dropbox.com/s/gm1wwse6easdv22/arss4.png?dl=0&raw=1)

![arss3.png](https://www.dropbox.com/s/amw9yemcr3p6klj/arss3.png?dl=0&raw=1)

Then I added my model with its animations. I created a simple particle effect that looked like embers
![arss5.png](https://www.dropbox.com/s/k2icj2ed1payxwa/arss5.png?dl=0&raw=1)

--------------------------------------

##### Problems I ran into

Working with the particle system in unity is not as easy as it looks. Having the right amount of particles displayed so that there wouldn't be any lag on the mobile device.

--------------------------------------

##### Features I would have liked to work

I would have liked to have a nicer particle effect orbiting the model.


