#Participants
The classes and objects participating in this pattern are:

## [Component   (DrawingElement)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Composite_Example/Component)

 declares the interface for objects in the composition.

 implements default behavior for the interface common to all classes, as appropriate.

 declares an interface for accessing and managing its child components.

 (optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.

## [Leaf   (PrimitiveElement)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Composite_Example/Leaf)

 represents leaf objects in the composition. A leaf has no children.

 defines behavior for primitive objects in the composition.

## [Composite   (CompositeElement)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Composite_Example/Composite)
 defines behavior for components having children.

 stores child components.

 implements child-related operations in the Component interface.

## [Client  (CompositeApp)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Composite_Example/Program.cs)

 manipulates objects in the composition through the Component interface.