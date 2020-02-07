
import 'package:flutter/material.dart';
import 'package:tictactoe/TicTacToeGame.dart';

import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';


class FlutterTicTacToeBoardSpace implements ITicTacToeBoardSpace{

  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardSpace(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe; 
  } 


  @overide
  Widget render(int idx){
    return Container(
      width: 50,
      child: Center(child: Text('${_tictactoe.gameState[idx]}',
        style: TextStyle(fontSize: 45),
        textAlign: TextAlign.center,
      ),)
    );

  }
}