package it.xpug.ocp.monopoly;

import java.util.*;


public class MonopolyPlayer {

	private int balance;
	private String playerName;
	private List<Object> ownedProperties = new ArrayList<Object>();

	public MonopolyPlayer(String playerName) {
		this.playerName = playerName;
	}

	public void setBalance(int newBalance) {
		this.balance = newBalance;
	}

	public int balance() {
		return this.balance;
	}

	public Object location() {
		return null;
	}

	public String playerName() {
		return playerName;
	}

	public void addOwnedProperty(String squareName) {
		ownedProperties.add(squareName);
	}

	public boolean isOwned(String squareName) {
		return ownedProperties.contains(squareName);
	}

	public void landsOn(String squareName) {
	}

}
