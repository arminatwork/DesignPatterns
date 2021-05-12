# Participants

 The classes and objects participating in this pattern are:

## [AbstractFactory  (ContinentFactory)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/AbstractFactory/AbstractFactory)

 declares an interface for operations that create abstract products.

## [ConcreteFactory   (AfricaFactory, AmericaFactory)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/AbstractFactory/ConcreteFactory)

 implements the operations to create concrete product objects.

## [AbstractProduct   (Herbivore, Carnivore)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/AbstractFactory/AbstractProduct)

 declares an interface for a type of product object.

## [Product  (Wildebeest, Lion, Bison, Wolf)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/AbstractFactory/Product)

 defines a product object to be created by the corresponding concrete factory.

 implements the AbstractProduct interface.

## [Client  (AnimalWorld)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/AbstractFactory/Client)

 uses interfaces declared by AbstractFactory and AbstractProduct classes.