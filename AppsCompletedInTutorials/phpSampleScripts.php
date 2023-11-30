<?php
/* ------------ Server Connection ----------- */

$servername = "localhost";
$username = "root";
$password = "";

try {
  $conn = new PDO("mysql:host=$servername;dbname=note_db", $username, $password);
  // set the PDO error mode to exception
  $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  echo "Connected successfully";
} catch(PDOException $e) {
  echo "Connection failed: " . $e->getMessage();
}

/* ----------- File upload ---------- */

if(isset($_FILES['image']))
{

	$extension = pathinfo($_FILES['image']['name'], PATHINFO_EXTENSION);

	$new_name = time() . '.' . $extension;

	move_uploaded_file($_FILES['image']['tmp_name'], 'public/images' . $new_name);

	$data = array(
		'image_source'		=>	'public/images' . $new_name
	);

	echo json_encode($data);

}

/* ------------- Other File Upload ------------------ */

 $allowed_ext = array('png', 'jpg', 'jpeg', 'gif');

 if(isset($_POST['submit'])) {
   
    // Check if file was uploaded
    if(!empty($_FILES['upload']['name'])) {
    $file_name = $_FILES['upload']['name'];
    $file_size = $_FILES['upload']['size'];
    $file_tmp = $_FILES['upload']['tmp_name'];
    $target_dir = "pubic/images${file_name}";

    // Get file extension
    $file_ext = explode('.', $file_name);
    $file_ext = strtolower(end($file_ext));

    // Validate file type/extension
    if(in_array($file_ext, $allowed_ext)) {
      // Validate file size
      if($file_size <= 1000000) { // 1000000 bytes = 1MB
        // Upload file
        move_uploaded_file($file_tmp, $target_dir);

        // Success message
        echo '<p style="color: green;">File uploaded!</p>';
      } else {
        echo '<p style="color: red;">File too large!</p>';
      }
    } else {
      $message = '<p style="color: red;">Invalid file type!</p>';
    }
   } else {
     $message = '<p style="color: red;">Please choose a file</p>';
   }
 }

/* ------------- Other File Upload ------------------ */

if (isset($_POST['submit']) && isset($_FILES['image']['name'])) {

    $allowedExts = array("gif", "jpeg", "jpg", "png");
    $temp = explode(".", $_FILES["image"]["name"]); //explode is an array of strings with a seperator
    $extension = end($temp); //end is used to find the last element in a given array
    if ((($_FILES["image"]["type"] == "image/gif")
            || ($_FILES["image"]["type"] == "image/jpeg")
            || ($_FILES["image"]["type"] == "image/jpg")
            || ($_FILES["image"]["type"] == "image/pjpeg")
            || ($_FILES["image"]["type"] == "image/x-png")
            || ($_FILES["image"]["type"] == "image/png"))
        && ($_FILES["image"]["size"] < 500000)
        && in_array($extension, $allowedExts))                                              
    {
        if ($_FILES["image"]["error"] > 0) {
            echo "Return Code: " . $_FILES["image"]["error"] . "<br>";
        } else {
            $ext = end(explode(".", $_FILES["image"]["name"]));
            $filename = current(explode(".", $_FILES["image"]["name"]));
            $newname = $filename . '_' . time() . '.' . $ext;
            move_uploaded_file($_FILES["image"]["tmp_name"],
                "public/images" . $newname);
        }
    } else {
        echo "<div class='alert alert-success'>Image type or size is not valid.</div>";
    }
}

/* ---------- File Handling --------- */

/* 
  File handling is the ability to read and write files on the server.
  PHP has built in functions for reading and writing files.
*/

$file = 'extras/users.txt';

// if(file_exists($file)) {
//   // Returns the content and number of bytes read from the file on success, or FALSE on failure.
//   echo readfile('extras/users.txt');
// }

// File Open, Read, Write, Close
if (file_exists($file)) {
  // fopen() gives you more control over the file.
  // Modes: r, w, a, x, r+, w+, a+, x+ See below for details
  $handle = fopen($file, 'r');
  // fread() reads the file and returns the content as a string on success, or FALSE on failure.
  $contents = fread($handle, filesize($file));
  // fclose() closes the file resource on success, or FALSE on failure.
  fclose($handle);
  echo $contents;
} else {
  // Create the file
  $handle = fopen($file, 'w');
  // PHP_EOL is a constant that represents the end of line character.
  $contents = 'Brad' .  PHP_EOL . 'Sara' .  PHP_EOL . 'Mike' .  PHP_EOL . 'John';
  // fwrite() writes the contents to the file and returns the number of bytes written on success, or FALSE on failure.
  fwrite($handle, $contents);
  fclose($handle);
}

/*
r	- Open a file for read only. File pointer starts at the beginning of the file
w	- Open a file for write only. Erases the contents of the file or creates a new file if it doesn't exist. File pointer starts at the beginning of the file
a	- Open a file for write only. The existing data in file is preserved. File pointer starts at the end of the file. Creates a new file if the file doesn't exist
x	- Creates a new file for write only. Returns FALSE and an error if file already exists
r+ -	Open a file for read/write. File pointer starts at the beginning of the file
w+ -	Open a file for read/write. Erases the contents of the file or creates a new file if it doesn't exist. File pointer starts at the beginning of the file
a+ -	Open a file for read/write. The existing data in file is preserved. File pointer starts at the end of the file. Creates a new file if the file doesn't exist
x+	- Creates a new file for read/write. Returns FALSE and an error if file already exists
*/

/* --- $_GET & $_POST Superglobals -- */

/*
  We can pass data through urls and forms using the $_GET and $_POST superglobals.
*/

if (isset($_POST['submit'])) {
    // echo '<h3>' . $GET['username'] . '</h3>';
    echo '<h3>' . $_POST['username'] . '</h3>';
  } ?>
  
  <!-- Pass data through a link -->
  <a href="<?php echo $_SERVER['PHP_SELF']; ?>?username=Brad">Link</a>
  
  
  <br><br>
  
  <!-- Pass data through a form -->
  <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
  <div>
    <label>Name: </label>
    <input type="text" name="name">
  </div>
  <br>
  <div>
  <label>Password: </label>
    <input type="password" name="password">
  </div>
  <br>
    <input type="submit" name="submit" value="Submit">
  </form>
