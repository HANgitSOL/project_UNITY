# Activities in this week is following the second tutoiral provided by 'Unity'
🙌 Check this [link](https://learn.unity.com/project/unit-4-gameplay-mechanics?uv=2018.4&courseId=5cf96c41edbc2a2ca6e8810f) for original tutorial   
<br>
<br>
**Now I Can**<br>
- detect collision and make the engine conduct some action<br>
- use coroutine in script<br>
<br>

📂 **'code'** folder gives information about basic manipulation of unity<br>

<br>


- - -

❗ **NOTE for me** ❗<br>
🔅I should follow the tutor entirely.<br>
<br>
Using collider and make some action has been a serious trouble for a while.<br>
Because if I cannot detect collision and make some action, I tentatively cannot do anything in game.<br>
In fact, in previous week, I didn't conduct this process. (although this might be because I did not set rigid body on game object)<br>
In this week, I also could not use collider although I set rigid body on player and set tag on power-up gem.<br>
Searching internet, I discovered that everyone using unity use same function name _'OnTriggerEnter'_ and I wrote this function name as _'OntriggerEnter'_.<br>
I came to know that this function is provided by Unity, and so I should the _completely same_ function name to make Unity conduct this work.<br>
Now I guess that if the function is used in _Update()_ loop, I can make the name of function as I want, however if I do not use the function in _Update()_ loop(a.k.a. built-in function), I should use specific name of function.<br>
<br>
<br>
🔅Coroutine means temporary pause of script.<br>
<br>
Coroutine is another system in Unity.<br>
If the coroutine is called, the function will temporary get the control of Unity.<br>
Coroutine is used similary with other functions, but it should be called in Update() loop using _'StartCoroutine()'_ function.<br>
This function(coroutine) should be made by using _IEnumerator_ not by using _void_, _private void_ or _private Vector3_.<br>
And this function(coroutine) should possess _'yield'_ in function identification. (however, I don't know why...)
