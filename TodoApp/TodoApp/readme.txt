
1. In the TodoController.cs class there are a few methods that need added.
May need to watch a basic WebAPI introduction.

2. Extend the TODO model so that it has the following properties:
	Description
	CreatedDate
	CreatedBy
	DueDate

3. Extend the Todo item to have a Type, this could be an enum
 - Add the following types -  meeting, general, job
 - Now for meeting we want to add a location but we dont really need that property on general and job
 - Use inheritance to work out a nice model

 4. Add a Type property to each todo item to tell what kind of todo it is.