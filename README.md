# Hi, I am TensorflowVisual

Tensorflow_Toolkit is an open source software library written in C# that exposes **[tensorflow](https://github.com/tensorflow/tensorflow)**
to visual programming interfaces like [Grasshopper](https://www.grasshopper3d.com/)
and [Dynamo](https://www.autodesk.com/products/dynamo-studio/overview) thorugh the [.Net bindings](https://github.com/migueldeicaza/TensorFlowSharp) from https://github.com/migueldeicaza

This is a work in progress and aims at creating a high-level api to enable mass partecipation and fast experimentations with deep learning.

---
## To get started
The code relies on the BHoM library, which reflects teh assembly to the visual programming platforms.
Let's get started with Grasshopper.

1. `cd` to your favourite folder and clone the necessary repositories. It is important that they are in the same folder.
```
git clone https://github.com/BHoM/BHoM
git clone https://github.com/BHoM/BHoM_Engine
git clone https://github.com/BHoM/BHoM_Adapter
git clone https://github.com/BHoM/Rhinoceros_Toolkit
git clone https://github.com/BHoM/Grasshopper_Toolkit
```

2. Compile the libraries above. They are based on the C# framework 4.6.1, so any modern Visual Studio version should be ok.

3. Compile the Tensorflow

4. Compile the Grasshopper_Toolkit again.

5. Done, you can open Grasshopper and start building your graph

---
## What can you do right now?

The status of the code allows you to build a graph for now, and run a foward pass through a tensorflow session.
All the [c++ tensorflow ops](https://github.com/tensorflow/tensorflow/tree/master/tensorflow/cc/ops) are exposed.

---
## What is the road map?
[Keras](https://github.com/keras-team/keras) is a good example of a high-level api that uses tensorflow as a backend.
Miming some of its high level functionalities would be a good start. More is to come.
