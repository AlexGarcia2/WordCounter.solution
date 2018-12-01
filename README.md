# _WordCounter_

#### _An appilcation for finding words, 11.30.2018_

#### By ** _Alex Garcia_**

## Description

_An program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.) Also, do not use regular expressions in your logic.d ._

## Setup/Installation Instructions

_download source code from Github need a dotnet and c# compiler to run test and code.

## Known Bugs

* _No known bugs._

## Specifications

  [model test]

* check to see if one letter are the same.
  * Example Input: A & A
      * Example Output: true

* be able to compare if word  given can be matched if there is a capital letter in the word.
    * Example Input:  cat and Cat
      * Example Output: false words dont equal each other

* be able to see if an empty list can be given back.
    * Example Input: List<string>{}
      * Example Output: true

* be able to match a word that is given to words in a sentence .
    * Example Input:"to"/ "people love to look at small things together"
      * Example Output: output of true if element is found in string

* find how many times a given word is repeated in a given sentence .
    * Example Input: "people go to work an then go home"
    * example Input: "go"
      * Example Output: go appears twice (2)

    [controller test]  

* find if the controller is passing through the right Action type.
    * Example Input: Index
      * Example Output: Index

*  find if the controller passes through the correct model data type
    * Example Input: list<string>
      * Example Output:List<string>
* find if the controller can pass the correct data type
      * Example Input: RedirectToActionResult
        * Example Output: RedirectToActionResult




## Support and Contact Details

_If you discover a bug or want to make a suggestion or comment, send us an email at g.nightster11@gmail.com or file an issue on Github._

## Technologies Used

_This application uses dotnet, c# , mvc, razor_

### License

Copyright (c) 2018 **_ Alex Garcia_**

This software is licensed under the MIT license. Quits-_
