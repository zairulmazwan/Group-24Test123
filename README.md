# Group-24
Group Assignment



# Done:-
- Sign Up

- home page layout


# Still to do:-
- Sign in 

- View users (admin only) 
	delete users
	edit users

- Upload images (only allowed access to users logged in)

- individual image page (one standard page but changes with the image id given to it after clicking an image) 'SELECT * FROM imagesDatabase WHERE imageID = 5' then use the url returned from that to display the image on the page within the img tags like <img src="THE_URL_FROM_THE_DATABASE"/> and form containing a download button this also needs a hidden text field containing the id for the image being downloaded <input type="hidden" id="image_to_download" value="THE_ID_FROM_THE_DATABASE_FOR_THE_IMG" /> then it will link to a page that simple just handles the download and returns back to the individial image page see line below

- Download images 'SELECT * FROM imagesDatabase WHERE imageID = THE_ID_FOR_THE_IMG_FROM_THE_HIDDEN_TEXT_FIELD' select an image and then download it using the ID provided from the hidden text field within the individual image page. then use the  Users must also be logged in

- Home page (currently just displays dummy images. It needs to grab URL's from the uploaded images and display them) using e.g. 'SELECT * FROM imagesDatabase'

- 3x catagory pages (e.g. forest images, sea images, space images) display in the top bar and use the same code used on the home page to select all images by type using e.g. 'SELECT * FROM imagesDatabase WHERE type = "forest"'


