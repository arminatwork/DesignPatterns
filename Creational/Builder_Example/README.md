# Participants

   The classes and objects participating in this pattern are:

## [Builder  (VehicleBuilder)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/Builder_Example/Builder)

 specifies an abstract interface for creating parts of a Product object.

## [ConcreteBuilder  (MotorCycleBuilder, CarBuilder, ScooterBuilder)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/Builder_Example/ConcreteBuilder)

 constructs and assembles parts of the product by implementing the Builder interface.
 defines and keeps track of the representation it creates.
 provides an interface for retrieving the product.

## [Director  (Shop)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/Builder_Example/Director)

 constructs an object using the Builder interface.

## [Product  (Vehicle)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/Builder_Example/Product)

 represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.

 includes classes that define the constituent parts, including interfaces for assembling the parts into the final result.