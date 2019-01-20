var guessItem = null;
var interval = 100;
var solution;
var results = [];
var gameOver = false;

function setup() {
  createCanvas(800, 300);
}

function draw() {
	var gameScore = getGameScore(results);
	
	if (gameScore.loss === 3 || gameScore.total === 10){
		displayGameOver(gameScore);
		gameOver = true;
		return;
	}
	
  background(220);
	if(frameCount % interval === 1){
		solution = null;
		guessItem =  new GuessItem(width/2,height/2,10);
		
	}
	
	if(guessItem){
		guessItem.render()
	}
	
	
	if(solution === true){
		background(255);
	} else if (solution === false){
		background(0);
	}
}

function displayGameOver(score){
	push();
	background(255)
	textAlign(CENTER,CENTER);
	translate(width/2,height/2);
	fill(237,34,93);
	textSize(24);
	text('GAME OVER!',0,0);
	
	fill(0);
	translate(0,36);
	text('You have ' + score.win + ' correct guesses',0,0);
	
	var alternatingValue = map(sin(frameCount/10),-1,1,0,255)
	
	fill(237,34,93,alternatingValue);
	textSize(16);
	translate(0,80);
	text('PRESS ENTER',0,0);
	pop();
}

function getGameScore(score){
	var wins = 0;
	var losses = 0;
	var total = score.length;
	
	for(var i = 0; i < total;i++){
		var item = score[i];
		if(item === true){
			wins++;
		} else {
			losses++;
		}
	}
	return {win:wins, loss:losses,total:total};
}

function restartGame(){
	results = [];
	solution = null;
	gameOver = false;
}

function keyPressed(){
	if(gameOver === true){
		if(keyCode === ENTER){
			restartGame();
		}
	}
	
	if(guessItem != null){
		console.log('you pressed',key);
		solution = guessItem.solve(key);
		if(solution){
			results.push(true);
		} else {
			results.push(false);
		}
		guessItem = null;
	} else {
		console.log('Nothing to be solved...');
	}
	
}

function GuessItem(x,y,scl){
	this.x = x;
	this.y = y;
	this.scale = scl;
	this.scaleIncrement = 0.5;
	this.content = getContent();
	this.alpha = 255;
	this.alphaDecrement = 3;
	this.solved;
	
	function getContent(){
		return String(parseInt(random(10),10));
	}
	
	this.solve = function(input){
		if(input === this.content){
			this.solved = true;
		} else {
			this.solved = false;
		}
		return this.solved;
	}
	
	this.render = function(){
		if(this.solved === false){
			return;
		}
		
		push();
		fill(0,this.alpha);
		textAlign(CENTER,CENTER);
		translate(this.x,this.y);
		scale(this.scale);
		text(this.content, 0, 0);
		this.scale = this.scale + this.scaleIncrement;
		this.alpha = this.alpha - this.alphaDecrement;
		pop();
	}
}



