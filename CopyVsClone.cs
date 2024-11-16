for better understanding of copy and clone we need to have prior knowledge on how reference types will store in memory and how 

ClassA obj = new ClassA();

we all know that whenever we create an object like above For ex: obj variable will store in stack but ClassA's members(actual object) will store in Heap and the reference/address of class members/object(Heap) will be stored in obj variable(stack).

So whenever we copy obj to another ClassA variable we are not creating new memory instead we are just copying the value(which is reference/address) from obj to obj1.

ClassA obj1 = obj;

In this case, in heap memory created only once and the same reference/address will be stored in both obj and obj1.

The problem with this approach is if you change any obj member, the same will be applied to obj1 as well, as both are sharing same object.

now lets see with an example.

obj1.Id = 2;
Console.WriteLine(obj.Id);//2 - which is expected
Cosnole.WriteLine(obj1.Id);//2 - ***we didn't assign value 2 for obj1.Id but its because of the same reference of obj and obj1.

