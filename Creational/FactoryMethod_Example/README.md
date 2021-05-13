# Participants

 The classes and objects participating in this pattern are:

## [Product  (Page)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/FactoryMethod_Example/Product)

 defines the interface of objects the factory method creates.

## [ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/FactoryMethod_Example/ConcreteProduct)

 implements the Product interface.

## [Creator  (Document)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/FactoryMethod_Example/Creator)

 declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.

 may call the factory method to create a Product object.

## [ConcreteCreator  (Report, Resume)](https://github.com/arminatwork/DesignPatterns/tree/master/Creational/FactoryMethod_Example/ConcreteCreator)

 overrides the factory method to return an instance of a ConcreteProduct.