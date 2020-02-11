
import 'package:flutter/material.dart';
import 'package:tictactoe/TicTacToeGame.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardLine/ITicTacToeBoardLine.dart';


class FlutterTicTacToeBoardLine implements ITicTacToeBoardLine{

  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardLine(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe; 
  } 

  @override
  Widget render(int idx){
    return Container(
      decoration: BoxDecoration(
        color: Colors.white, 
        border: Border.all(
          color: Colors.black,
          width: 1,
        ),
        borderRadius: BorderRadius.circular(6)
      ),
      margin: const EdgeInsets.all(3),
      width: 50,
      child: Center(child: Text('${_tictactoe.gameState[idx]}',
        style: TextStyle(fontSize: 45),
        textAlign: TextAlign.center,
      ),)
    );

  }
}