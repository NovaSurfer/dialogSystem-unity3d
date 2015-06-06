# Unity3d Dialog System
######Simple and flexible dialog system for Unity3d

# Features:
* Easy to use
* Write the dialogues in your favorite text editor
* Tags (coming soon)

# TODO:
* Add more tags
* Change the size of the slider, based on the amount of text

# How to use:
**1) Create text file with dialog**  

`First dialog file` 
>Hi I'am Alex.  
>Hi I'am Tom. #->testText1  

`Second dialog file` 
>How are you Tom?  
>Awesome possum! #->testText  
>All is bad... #->testText  

 `First line`   =   main window text  
 `Other lines`  =   answer text  
 `After #->`    =   next dialog file
 
 **2) Create folder "Resources" and place your dialogs here**   
 ![Resources](https://habrastorage.org/files/d62/9cd/e1c/d629cde1ced04d19b60b81b87b22fa55.png)  
 **3) Create UI elements like: main dialog panel, prefabs with answer button**  
 **4) Add Canvas to "Canvas" tag, add answer prefab to "Answer" tag**  
 **5) Attach FileReader script to the Canvas**  
 **6) Fill in all required fields with variables**  
 **7) Attach nextDilog script to the answerButton prefab**  
 ![Canvas](https://habrastorage.org/files/6d2/607/f20/6d2607f20ca94e67b8bad8fc49cef022.png)    ![Answer](https://habrastorage.org/files/990/2f0/4e4/9902f04e411d4c4c99504c6a0b672183.png)  



