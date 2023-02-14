# Data Structures N Algorithms

# MVP Matrix

- project everything in to 2D space.
- multiply each vertex with projection matrix
- perspective projection matrix, orthographic projection matrix, if you want a custom projection matrix you can create one for yourself

- Projection matrix will be responsible for :

  1. Aspect ratio : adjust x and y values based on the screen width & height values
  2. Field of view : adjust x and y values based on the FOV angle
  3. Normalization : adjust the x,y,z values to sit between -1 and 1

- Perspective divide is when we divide x and y by depth(z)
- This makes sense, since points that are closer to us should appear bigger and points that are far way should appera smaller.
