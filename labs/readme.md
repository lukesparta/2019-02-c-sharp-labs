Files and Folders : Encoding

Intro

	Programmers need to be skilled in 

		Files
		Folders
		Streaming : sending data to another computer
		Serialization : take object with fields, properties, methods and effectively
			'flat-pack' reading for sending out (streaming)

			Think IKEA 				Our Computer

			Plans for design			Class : blueprint to create new objects
									
									 class Parent{
										public string Name;
									 }
													
			Build furniture item			Instantiate : create 'real' object	

									var p01 = new Parent();
									p01 is new object
									Parent is class

			Flat pack item 				Serialize p01 to a string of
								characters   aasdkflasdasdfa
								or binary  10101010101001

			Send it to you 				Streaming (buffer if traffic
									gets delayed)

			Build item (from instructions)       	Instructions : Class (required)
								De-serialize back into p01 object again

	Streaming to another computer (OR OUR OWN COMPUTER!)

		3 types

			1. local filing system
			2. RAM (memory) of local computer
			3. Network
				Internet http:// or https:// (encrypted)
				Share    //server/share
				Internet : port (channel) eg 80 : http, 443 https, 22 ssh (linux)
				Socket  written IP:PORT  eg 216.58.208.174:80

			
Encoding

	If are using data, files etc we must be aware of ENCODING!!!

	ENCODING is format in which we lay down our binary '1' and '0' in order to create a file

File Signature

	Every file has 'signature' which tells us if it's TXT, JPG, DOCX, PNG, MOV, etc

	Mr            + Joe Bloggs	

	xxSIGNATURExx + data

	FF D8         + data   ==> JPG PICTURE

	50 4B 03 04   + data   ==> ZIP OR DOCX


Encoding

	Two types of laying out data as a file

	1. Binary 

	2. Character-based 

	Binary 

		In C# we deal with 'compiled' files EXE and DLL

			run program .EXE but it refers (right click, add reference) to other 
					code which are imported as .DLL files so we can use them
		
		Binary files look like 1010101010101010 (raw binary) and cannot be read
			by a human as text; we must have the right application to decoded them
			eg Microsoft Word or Photoshop etc

		Advantage : already in raw binary so NO CONVERSION REQUIRED TO SEND/RECEIVE

			FASTEST POSSIBLE WAY TO SEND DATA (RAW BINARY)

			 : fully compiled so can talk to computer when running at fastest 
				possible speed 

	Character Based Encoding

		Most data is this format

			XML   Microsoft systems

			JSON  { field1: "data1", field2: "data2", field3: 12 }

			TEXT
			
			HTML, CSS, JAVASCRIPT

	
	Common Encoding Types

		ASCII

		UTF-8

		UTF-16

			
		ASCII allocates a number from 0 to 127 for every key on the keyboard

			Letter a represents 97
                               b            98

			7 bits (2 power 7 = 128) for storage

	
		UTF-8

			Default for 1) INTERNET 2) C#
	

			UTF8 is simple ASCII with extra bit added

				128	64	32	16	8	4	2	1
		a	ASCII            1      1       0       0       0        0      1       
		b	ASCII            1      1       0       0       0        1      0       

		UTF8 

		a	UTF8     0       1      1       0       0       0        0      1       
		b	UTF8     0       1      1       0       0       0        1      0       


	UTF-16 also called UNICODE
	
		Problem with ASCII is only standard US-English characters used.
	
		UTF-16 uses 2 BYTES FOR EVERY CHARACTER.  THIS ALLOWS US TO USE CHARACTERS
			FROM EVERY LANGUAGE IN THE WHOLE WORLD.  THIS ALLOWS COMMUNICATION 
			BETWEEN PEOPLE OF ALL LANGUAGES USING STANDARD COMPUTER


	Care must be taken as a programmer dealing with data

		eg  Saving a text file : line endings are different for : 

			Windows
			Linux

Conclusion
	Serialisation
	Streaming
	Encoding
	ASCII
	UTF-8
	UTF-16