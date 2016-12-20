$(document).ready(function(){
    $.getJSON('data.json', function(data){makeTable(data);});
    
});

function makeTable(all_data){
	var i = 0;
	var row = '';
	const N = 5;
	console.log('All', all_data);
	$(all_data).each(function(index, element){  
		console.log(i);
		i = i + 1;
		var user_id = element['id'];
		row = row + '<td><a href="http://dz.hse7.ru/' + user_id+ '/svg/" target="_blank"><img src="http://dz.hse7.ru/' + user_id+ '/svg/screen.jpg"  onError="this.onerror=null;this.src=\'http://dz.hse7.ru/c.jpg\';"/></a> <br /> <span class="score">'+element['score']+'</span> &nbsp;&nbsp; <span class="author">'+element['name']+'</span> &nbsp;&nbsp; <span class="vote"> <select id="'+ user_id +'_vote"><option>&nbsp;?</option><option>&nbsp;5</option><option>&nbsp;4</option><option>&nbsp;3</option><option>&nbsp;2</option><option>&nbsp;1</option></select></span></td>';
		if(i % N == 0){
			$('#t0').append('<tr>' + row + '</tr>');
			row = '';
			i = 0;
		};
	})

	if (all_data.length % N != 0){
		$('#t0').append('<tr>' + row + '</tr>');
	}
	$(".score").hide()
	$("select").hide()
	$("select").change(function(){
		$.get("log.php", {"name":this.id, "vk_user": vk_user_name, "mark":this.value});
	})
};
