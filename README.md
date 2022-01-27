# CouaCurves
![1](/Logos/Coua1.png)
Coua Curves is a basic C# library for for quickly generating curves and evaluating them. 

## About

I created this basic library for the purpose of having quick access to things like Bezier Curves when making animations for applications.  Sometimes all I need is to evaluate a simple curve rather than deal with a bulky animator.  

### The "CouaVector2" struct

A simple struct for holding X and Y values on a graph.  

### The "CouaBezier" class

A class that holds 4 control points that will form our bezier curve.  These points can be set through the "SetPointA(), SetPointB() ..." methods. The parameter "position" refers to the point's value on the X axis.  Paramter "value" refers to the point's value on the Y axis.

#### Evaluate()

Evaluates the curve at _t_ and returns both it's X and Y value as a "CouaVector2".

#### EvaluateY()

Evaluates the curve at _t_ and returns it's Y position.  This is used most often.

#### EvaluateX()

Evaluates the curve at _t_ and returns it's X position.  