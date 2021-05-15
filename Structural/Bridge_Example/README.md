# Participants

 The classes and objects participating in this pattern are:

## [Abstraction   (BusinessObject)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Bridge_Example/Abstraction)

 defines the abstraction's interface.

 maintains a reference to an object of type Implementor.

## [RefinedAbstraction   (CustomersBusinessObject)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Bridge_Example/RefinedAbstraction)

 extends the interface defined by Abstraction.

## [Implementor   (DataObject)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Bridge_Example/Implementor)

 defines the interface for implementation classes. This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.

## [ConcreteImplementor   (CustomersDataObject)](https://github.com/arminatwork/DesignPatterns/tree/master/Structural/Bridge_Example/ConcreteImplementor)

 implements the Implementor interface and defines its concrete implementation.