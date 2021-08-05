<script lang="ts">
    	import Counter from '$lib/Counter/index.svelte';
import ButtonElement from '$lib/Elements/Buttons/ButtonElement.svelte';
import PlayButton from '$lib/Elements/Buttons/PlayButton.svelte';
import InputElement from '$lib/Elements/InputElement.svelte';
</script>



<div>
    <h1>Elements</h1>

    <p>Buttons</p>
    <ButtonElement buttonText={"button outline"} isOutline={true}/>
    <ButtonElement buttonText={"button primary"} isOutline={false}/>
<!-- <PlayButton /> -->
    <hr />

    <InputElement inputLabel={"First Name"} placeholderText={"Aravind"}/>

</div>