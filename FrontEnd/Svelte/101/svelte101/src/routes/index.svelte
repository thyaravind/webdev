<script context="module" lang="ts">
	export const prerender = true;
</script>

<script lang="ts">
	import Counter from '$lib/Counter/index.svelte';
import ButtonElement from '$lib/Elements/ButtonElement.svelte';
import InputElement from '$lib/Elements/InputElement.svelte';
</script>

<svelte:head>
	<title>Home</title>
</svelte:head>

<section>
	<h1>Component library</h1>
</section>


<p>Elements</p>

<ButtonElement buttonText={"button outline"} isOutline={true}/>
<hr />
<ButtonElement buttonText={"button primary"} isOutline={false}/>
<hr/>
<InputElement inputLabel={"First Name"} placeholderText={"Aravind"}/>


<style>
	section {
		display: flex;
		flex-direction: column;
		justify-content: center;
		align-items: center;
		flex: 1;
	}

	h1 {
		width: 100%;
	}
</style>
