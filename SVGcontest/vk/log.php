<?php

$myfile = fopen("log.txt", "a+");
$date = new DateTime();
$stamp =  $date->format('Y-m-d H:i:s');
$log_line = $stamp.", ".$_GET["vk_user"].", ".$_GET["name"].", ".$_GET["mark"]."\n";
fwrite($myfile, $log_line);
fclose($myfile);
echo $log_line;

?>
</pre>