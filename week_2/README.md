# Activities in this week is following the second tutoiral provided by 'Unity'
🙌 Check this [link](https://learn.unity.com/project/unit-2-basic-gameplay?uv=2019.4&courseId=5cf96c41edbc2a2ca6e8810f) for original tutorial   
<br>
<br>
**Now I Can**<br>
- restrict movement of game object<br>
- make game object automatically being removed over some limitation<br>
<br>

📂 **'food'** folder gives information about basic manipulation of unity<br>

📂 **'ball'** folder is for _challenge mission_ <br>
<br>


- - -

❗ **NOTE for me** ❗<br>
🔅Let's assume that the 'void Update()' is same with 'while' loop which is repeated until the end of game.<br>
<br>
In tutorial, tutor organized codes to bring the player to same time again and again if it escapes the limitted range to restrict the range of movement.<br>
I thought that this process is unnecessary, and it would be better to take input in only when the player in some boundary.<br>
So, I tried this using the function _Abs_ that gives me the absolute value of input.<br>
This operation succeeded in restricting the player from going out of the specified range.<br>
However, this operation is incomplete because it ignored the input after restriction..<br>
I think that the more consideration is needed..<br>
<br>
<br>
🔅What is the _Prefab_ ?<br>
<br>
It is the bung-u-bbang frame that Minjae said.<br>
When I use objects provided by tutorial, I use a prefab of object.<br>
If I drag some objects from _hierarchy_ to folders in _Project_ , I can make prefabs.<br>
<br>
If you want to apply some script to prefab through object in hierarch, check _Overrides_ .<br>
And the duplicated object will have same script.<br>
<br>
<br>
🔅How can I get to know current time using C#?<br>
<br>
I tried to know the method for this goal, but I failed..<br>
You can see my tries in _'PlayerControllerX.cs'_ .<br>
🦕 __MinJae__ 🦕 said "Use 'Time' class, specifically 'Time.time'."
